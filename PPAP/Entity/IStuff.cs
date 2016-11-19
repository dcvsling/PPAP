namespace PPAP.Entity
{
    using System.Collections.Generic;
    /// <summary>
    /// base stuff 
    /// </summary>
    public interface IStuff
    {
        string Name { get; }
    }

    /// <summary>
    /// a stuff
    /// </summary>
    /// <typeparam name="TStuff"></typeparam>
    public interface IStuff<TStuff> :IStuff
        where TStuff : IStuff
    {
    }

    /// <summary>
    /// stuff after two stuff do n~~~~~~
    /// </summary>
    /// <typeparam name="TStuffLeft"></typeparam>
    /// <typeparam name="TStuffRight"></typeparam>
    public interface IStuff<TStuffLeft,TStuffRight> : IStuff
        where TStuffLeft : IStuff
        where TStuffRight : IStuff
    {
    }

    /// <summary>
    /// stuff after four stuff do n~~~~~ twice
    /// </summary>
    /// <typeparam name="TStuffLL"></typeparam>
    /// <typeparam name="TStuffLR"></typeparam>
    /// <typeparam name="TStuffRL"></typeparam>
    /// <typeparam name="TStuffRR"></typeparam>
    public interface IStuff<TStuffLL,TStuffLR,TStuffRL,TStuffRR> : IStuff
        where TStuffLL : IStuff 
        where TStuffLR : IStuff 
        where TStuffRL : IStuff 
        where TStuffRR : IStuff
    {
        void Dance();
    }
}
