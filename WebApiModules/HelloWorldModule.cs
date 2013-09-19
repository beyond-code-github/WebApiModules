﻿namespace WebApiModules
{
    using Superscribe.Models;
    using Superscribe.WebApi.Modules;

    using WebApiModules.Services;

    public class MessageWrapper
    {
        public string Message { get; set; }
    }

    public class HelloWorldModule : SuperscribeModule
    {
        public HelloWorldModule()
        {
            this.Get["/"] = o => new { Message = "Hello World" };

            this.Get["Hello" / (ʃString)"Name"] = o =>
            {
                var helloService = o.Require<IHelloService>();
                return new { Message = helloService.SayHello(o.Parameters.Name) };
            };

            this.Post["Save"] = o =>
            {
                var wrapper = o.Bind<MessageWrapper>();
                return new { Message = "You entered - " + wrapper.Message };
            };
        }
    }
}