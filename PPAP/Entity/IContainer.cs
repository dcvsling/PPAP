using System;
using System.Collections.Generic;
using System.Text;

namespace PPAP.Entity
{
    /// <summary>
    /// it's air container , it's can get and set anything and n~~~~~XD
    /// </summary>
    public interface IContainer
    {
        T Get<T>();
        void Set<T>(T t);

        TResult BinaryDo<TLeft, TRight, TDo, TResult>(TLeft left,TRight right);
    }
}
