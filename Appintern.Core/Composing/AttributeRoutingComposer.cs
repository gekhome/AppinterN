using Appintern.Core.Components;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Appintern.Core.Composing
{
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public class AttributeRoutingComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Insert<AttributeRoutingComponent>();
        }
    }
}
