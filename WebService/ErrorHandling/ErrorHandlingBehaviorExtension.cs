using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Configuration;

namespace WebService.ErrorHandling
{
    public class ErrorHandlingBehaviorExtension : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(ErrorHandlingBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new ErrorHandlingBehavior();
        }
    }
}