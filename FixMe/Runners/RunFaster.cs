using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using FixMe.Entities;
using FixMe.Options;

namespace FixMe.Runners
{
    public class RunFaster
    {
        private readonly RunnerOptions options;

        private object[] _all_the_irckles;

        public RunFaster()
        {
            options = new RunnerOptions();
            _all_the_irckles = Fill.FillDataObjectArray();
        }
        
        [Benchmark]
        public void Run() 
        {               
            using (StreamWriter sw = File.CreateText(options.FilePath))
            {
                foreach (var irckle in _all_the_irckles)
                {
                    if (irckle is Cuirckle)
                    {
                        var _irckle = irckle as Cuirckle;
                        double circumference = _irckle.Calculate;
                        sw.WriteLine($"Circumference of circle: {_irckle.RandomRadius}:{circumference}");
                        sw.Flush();
                    }
                    else
                    {
                        var _angle = irckle as Atrangle;
                        double area = _angle.Calculate;
                        sw.WriteLine($"Area of triangle: {area}");
                        sw.Flush();
                    }                    
                }               
            }
        }
    }
}
