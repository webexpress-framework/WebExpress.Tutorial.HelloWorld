using WebExpress.WebCore.WebApplication;
using WebExpress.WebCore.WebAttribute;

namespace WebExpress.Tutorial.HelloWorld
{
    /// <summary>
    /// Represents the main application class.
    /// </summary>
    [Name("HelloWorld:app.name")]
    [Description("HelloWorld:app.description")]
    [Icon("/assets/img/helloworld.svg")]
    [ContextPath("/helloworld")]
    public sealed class Application : IApplication
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="context">The context that applies to the execution of the application</param>
        public Application(IApplicationContext context)
        {
        }

        /// <summary>
        /// Called when the application starts working. The call is concurrent. 
        /// </summary>
        public void Run()
        {
        }

        /// <summary>
        /// Disposes of the resources used by the application. This method is called when 
        /// the application is no longer needed and should release any unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }
    }
}
