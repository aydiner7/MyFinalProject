using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    // MethodInterception : Aspect : Methodun istenilen yerinde çalışacak yapı.

    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            // defansing code : gönderilen türün kontrolü sağlanıyor.
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // Gelen Validator Kurallarım new lendi.
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            // Validator kurallarımın base classındaki ilk generic type atandı.
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            // methodun parametrelerini gezerek, türüme eşit olan durumları getirir
            // ardından onları tek tek validate eder.
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
