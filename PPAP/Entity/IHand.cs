namespace PPAP.Entity
{
    using System;
    /// <summary>
    /// we need hand
    /// </summary>
    public interface IHand
    {
        /// <summary>
        /// show what thing on hand
        /// </summary>
        IStuff Stuff { get; }
    }

    /// <summary>
    /// hand maybe empty , so we can take some stuff
    /// </summary>
    public interface IEmptyHand : IHand
    {
        /// <summary>
        /// take some stuff
        /// </summary>
        /// <typeparam name="TStuff"></typeparam>
        /// <param name="stuff"></param>
        /// <returns></returns>
        IHand<TStuff> Take<TStuff>(Func<TStuff> stuff)
            where TStuff : IStuff;
    }

    /// <summary>
    /// hand maybe have something ,so we can drop thing
    /// </summary>
    /// <typeparam name="TStuff"></typeparam>
    public interface IHand<TStuff> :IHand where TStuff : IStuff
    {
        /// <summary>
        /// drop thing drom hand
        /// </summary>
        /// <returns></returns>
        (TStuff,IEmptyHand) Drop();
    }
}
