using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FixMe.Options
{
    public class RunnerOptions
    {
        /// <summary>
        /// The number of iterations our process is going to run;
        /// </summary>
        public int Iterations { get;} = 500000;

        /// <summary>
        /// The filepath that we want the cheat sheet to be printed to.
        /// </summary>
        public string FilePath { get; } = "./exam-cheat-sheet.cs";

    }
}
