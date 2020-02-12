using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStore.Builder.Computer_Sample
{
    abstract class ComputerBulder
    {
        public ComputerBulder()
        {
            ComputerProduct = new Computer();
        }
        protected IComputer ComputerProduct;

        protected abstract void BuildCPU(ICPU cpu);
        protected abstract void BuildMemory(IMemory memory);
        protected abstract void BuildHardDisk(IHardDisk hardDisk);
        protected abstract void BuildMonitor(IMonitor monitor);

        public virtual IComputer CreateComputer()
        {
            
            return ComputerProduct;
        }
    }
}
