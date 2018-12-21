using System;
using System.Reflection;

namespace Blockchain.Wallet.DigitalFinancialCore.WebApi.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}