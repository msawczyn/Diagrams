// 

// 

using Microsoft.CodeAnalysis;

namespace DotNetDiagrams
{

   internal static class SyntaxNodeHelper
   {
      public static T GetParent<T>(this SyntaxNode syntaxNode) where T: SyntaxNode
      {
         SyntaxNode node = syntaxNode;

         while (node != null && !(node is T))
            node = node.Parent;

         return node as T;
      }

      public static bool TryGetParentSyntax<T>(this SyntaxNode syntaxNode, out T result)
         where T : SyntaxNode
      {
         result = syntaxNode.GetParent<T>();

         return result != null;
      }
   }

}
