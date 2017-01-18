




using System.Web.Http;

namespace WebHooksDemo
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveAzureAlertWebHooks();

			config.InitializeReceiveGitHubWebHooks();

        }
    }
}
