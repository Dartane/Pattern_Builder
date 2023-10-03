using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PattaBeelder
{
    public class CheckBuilder : ICheckBuilder
    {
        private BueyrCheck _bueyrCheck;

        private readonly IEnumerable<Position> _position;

        

        public CheckBuilder(IEnumerable<Position> position)
        {
            _position = position;
            _bueyrCheck = new();
        }

        public void BuildHeader()
        {
            _bueyrCheck.Header =
                "\t\t\tLLC \"Bartender\" \n";

            _bueyrCheck.Header +=
                $"\t\t\tDATE: {DateTime.Now}\n";

            _bueyrCheck.Header +=
                "\n----------------------------------------------------------------------------------------------";

        }
        public void BuildPurList()
        {
            
            _bueyrCheck.PurList = 
                string.Join(Environment.NewLine,
                _position.Select(e =>
                $"\n{e.Name}\t\t{e.Price}\t\t{e.Count}$\t\t{e.TotalPrice}$"));

        }
        public void BuildItog()
        {
            _bueyrCheck.Itog =
                "\n----------------------------------------------------------------------------------------------";
            _bueyrCheck.Itog +=
                $"\n Total Price:\t" + 
                $"{_position.Sum(e => e.TotalPrice)}$";
        }
        public void BuildNumber()
        {
            _bueyrCheck.Number =
                "\n----------------------------------------------------------------------------------------------";
            _bueyrCheck.Number =
                "\n INN: 2353464562";
        }
        public BueyrCheck GetCheck()
        {
            BueyrCheck bueyrCheck = _bueyrCheck;
            _bueyrCheck = new();

            return bueyrCheck;
        }
    }
}
