using System;
using System.Collections.Generic;
using System.Text;

namespace StorePickup.Data
{
    public class StorePickUpConstants
    {
        public const string AppToken = "X-Vtex-Api-AppToken";
        public const string AppKey = "X-Vtex-Api-AppKey";
        public const string IsProduction = "X-Vtex-Workspace-Is-Production";
        public const string VtexIdCookie = "VtexIdclientAutCookie";

        public const string EndPointKey = "hook-notification";
        public const string AppName = "curbside-pickup";

        public const string HookPing = "ping";

        public const string MailService = "http://mailservice.vtex.com.br/api/mail-service/pvt/sendmail";
        public const string Acquirer = "StorePickup";

        public const string GitHubUrl = "https://raw.githubusercontent.com";
        public const string Repository = "vtex-apps/curbside-pickup/master";
        public const string TemplateFolder = "templates";
        public const string TemplateFileExtension = "json";

        public const string CommentDomain = "oms";
        public const string CommentType = "order";

        public const string ViewerCountry = "cloudfront-viewer-country";
        public const string ProviderId = "00000000-0000-0000-0000-000000000000";
        public const string EmailTo = "{{curbsidePickup.toEmail}}";

        public const string FORWARDED_HEADER = "X-Forwarded-For";
        public const string FORWARDED_HOST = "X-Forwarded-Host";
        public const string APPLICATION_JSON = "application/json";
        public const string HEADER_VTEX_CREDENTIAL = "X-Vtex-Credential";
        public const string AUTHORIZATION_HEADER_NAME = "Authorization";
        public const string PROXY_AUTHORIZATION_HEADER_NAME = "Proxy-Authorization";
        public const string USE_HTTPS_HEADER_NAME = "X-Vtex-Use-Https";
        public const string PROXY_TO_HEADER_NAME = "X-Vtex-Proxy-To";
        public const string VTEX_ACCOUNT_HEADER_NAME = "X-Vtex-Account";
        public const string ENVIRONMENT = "vtexcommercestable";
        public const string LOCAL_ENVIRONMENT = "myvtex";
        public const string VTEX_ID_HEADER_NAME = "VtexIdclientAutCookie";
        public const string HEADER_VTEX_WORKSPACE = "X-Vtex-Workspace";
        public const string APP_SETTINGS = "vtex.curbside-pickup";
        public const string ACCEPT = "Accept";
        public const string CONTENT_TYPE = "Content-Type";
        public const string HTTP_FORWARDED_HEADER = "HTTP_X_FORWARDED_FOR";

        public const string DATA_ENTITY = "StorePickup";
        public const string SCHEMA = "StorePickup";

        public class Status
        {
            public const string OrderCreated = "order-created";
            public const string OrderCompleted = "order-completed";
            public const string OnOrderCompleted = "on-order-completed";
            public const string PaymentPending = "payment-pending";
            public const string WaitingForOrderAuthorization = "waiting-for-order-authorization";
            public const string ApprovePayment = "approve-payment";
            public const string PaymentApproved = "payment-approved";
            public const string PaymentDenied = "payment-denied";
            public const string RequestCancel = "request-cancel";
            public const string WaitingForSellerDecision = "waiting-for-seller-decision";
            public const string AuthorizeFullfilment = "authorize-fulfillment";
            public const string OrderCreateError = "order-create-error";
            public const string OrderCreationError = "order-creation-error";
            public const string WindowToCancel = "window-to-cancel";
            public const string ReadyForHandling = "ready-for-handling";
            public const string StartHanding = "start-handling";
            public const string Handling = "handling";
            public const string InvoiceAfterCancellationDeny = "invoice-after-cancellation-deny";
            public const string OrderAccepted = "order-accepted";
            public const string Invoice = "invoice";
            public const string Invoiced = "invoiced";
            public const string Replaced = "replaced";
            public const string CancellationRequested = "cancellation-requested";
            public const string Cancel = "cancel";
            public const string Canceled = "canceled";
        }

        public class MailTemplates
        {
            public const string ReadyForPacking = "curbside-ready-for-packing";
            public const string PackageReady = "curbside-package-ready";
            public const string AtLocation = "curbside-at-location";
            public const string PickedUp = "curbside-picked-up";
            public const string CancelOrder = "curbside-cancel-order";
            public const string CancelPickUp = "curbside-cancel-pickup";
        }

        public class OrderCommentText
        {
            public const string ReadyForPacking = "Order items are ready to be packed for pickup";
            public const string PackageReady = "Shopper has been notified that items are ready for curbside pickup";
            public const string AtLocation = "Shopper has arrived at curbside pickup location";
            public const string PickedUp = "Curbside pickup items have been handed off to shopper";
        }

        public class TemplateSubject
        {
            public const string ReadyForPacking = "Curbside Pickup Ready For Packing";
            public const string PackageReady = "Curbside Pickup Package Ready";
            public const string AtLocation = "Curbside Pickup At Location";
            public const string PickedUp = "Curbside Pickup Items Picked Up";
        }

        public class Domain
        {
            public const string Fulfillment = "Fulfillment";
            public const string Marketplace = "Marketplace";
        }

        public class TemplateType
        {
            public const string Email = "E";
            public const string SMS = "S";
        }

        public class RedirectPage
        {
            public const string ThankYou = "thanks";
            public const string Cancelled = "cancelled";
            public const string Error = "oops";
            public const string Handover = "handover";
            public const string Notified = "notified";
        }

        public enum MailTemplateType
        {
            ReadyForPacking,
            PackageReady,
            AtLocation,
            PickedUp
        }
    }
}
