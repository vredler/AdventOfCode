using System.Threading.Tasks;
using AdventOfCode.Domain;

namespace AdventOfCode.Infrastructure
{
    public interface IAdventService
    {
        Task<PuzzleInput> GetPuzzleInput(int year, int day);
    }
}