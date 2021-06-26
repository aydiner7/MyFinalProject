using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        // params : Method içerisine istediğim kadar IResult parametresi verebiliyorum.
        // logics : İş kodlarım, yani kurallarım.
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    // kurala uymayanı haberdar ediyorum.
                    return logic;
                }
            }
            return null;
        }
    }
}
