#if CLIENT
// fake require Attribute
namespace System.ComponentModel.DataAnnotations
{
    public class RequiredAttribute : Attribute
    {
    }
}
#endif