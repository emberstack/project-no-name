 using System;
 using System.Threading.Tasks;

namespace ProjectNoName.Contracts
{
 public interface IClock
    {
        Task ShowTime(DateTime currentTime);
    }
}

