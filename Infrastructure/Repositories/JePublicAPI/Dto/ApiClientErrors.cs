using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeBackend.Infrastructure.Repositories.Dto
{
    public class ApiClientErrors
    {

        /// <summary>
        /// 'Continue' or 'SwitchingProtocols' or 'OK' or 'Created' or 
        /// 'Accepted' or 'NonAuthoritativeInformation' or 'NoContent' or
        /// 'ResetContent' or 'PartialContent' or 'MultipleChoices' or 
        /// 'Ambiguous' or 'MovedPermanently' or 'Moved' or 'Found' or 
        /// 'Redirect' or 'SeeOther' or 'RedirectMethod' or 'NotModified' or 
        /// 'UseProxy' or 'Unused' or 'TemporaryRedirect' or 'RedirectKeepVerb' or
        /// 'BadRequest' or 'Unauthorized' or 'PaymentRequired' or 'Forbidden' or 
        /// 'NotFound' or 'MethodNotAllowed' or 'NotAcceptable' or 'ProxyAuthenticationRequired'
        /// or 'RequestTimeout' or 'Conflict' or 'Gone' or 'LengthRequired' or 'PreconditionFailed'
        /// or 'RequestEntityTooLarge' or 'RequestUriTooLong' or 'UnsupportedMediaType' or
        /// 'RequestedRangeNotSatisfiable' or 'ExpectationFailed' or 'UpgradeRequired' or
        /// 'InternalServerError' or 'NotImplemented' or 'BadGateway' or 'ServiceUnavailable' or
        /// 'GatewayTimeout' or 'HttpVersionNotSupported'
        /// </summary>

        public string StatusCode {get;set;}
        public string Content {get;set;}

        /// <summary>
        /// 'None' or 'Completed' or 'Error' or 'TimedOut' or 'Aborted'
        /// </summary>

        public string ResponseStatus {get;set;}
        public string ExceptionName { get; set; }

    }
}
