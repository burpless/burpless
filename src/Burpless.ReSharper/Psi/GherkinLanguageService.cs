using System.Collections.Generic;
using System.Linq;
using Burpless.ReSharper.Parsing;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.ReSharper.Psi.Impl;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;

namespace Burpless.ReSharper.Psi
{
    [Language(typeof(GherkinLanguage))]
    public class GherkinLanguageService : LanguageService
    {
        public GherkinLanguageService(GherkinLanguage psiLanguageType, IConstantValueService constantValueService)
            : base(psiLanguageType, constantValueService)
        {
        }

        public override ILanguageCacheProvider CacheProvider => null;

        public override bool SupportTypeMemberCache => false;

        public override ITypePresenter TypePresenter => DefaultTypePresenter.Instance;

        public override bool IsCaseSensitive => true;

        public override ILexer CreateFilteringLexer(ILexer lexer)
        {
            return null;
        }

        public override ILexerFactory GetPrimaryLexerFactory()
        {
            return new GherkinLexerFactory();
        }

        public override IParser CreateParser(ILexer lexer, IPsiModule module, IPsiSourceFile sourceFile)
        {
            return new GherkinParser();
        }

        public override IEnumerable<ITypeDeclaration> FindTypeDeclarations(IFile file)
        {
            return Enumerable.Empty<ITypeDeclaration>();
        }
    }
}
