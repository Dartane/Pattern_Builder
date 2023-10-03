using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PattaBeelder
{
    public interface ICheckBuilder
    {
        void BuildHeader();

        void BuildPurList();

        void BuildItog();

        void BuildNumber();

        BueyrCheck GetCheck();
    }
}
