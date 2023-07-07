
namespace BrainHub.Dominio.Compartilhado
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> target, int count = 0)
        {
            Random r = new Random();

            if (count == 0)
                return target.OrderBy(x => r.Next());
            else 
                return target.OrderBy(X => r.Next(count)).Take(count);
        }
    }
}
