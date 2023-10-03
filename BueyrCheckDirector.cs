using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PattaBeelder
{
    public class BueyrCheckDirector
    {
        private readonly ICheckBuilder _builder;

        public BueyrCheckDirector(ICheckBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildHeader();

            _builder.BuildPurList();

            _builder.BuildItog();

            _builder.BuildNumber();
        }
    }
}
