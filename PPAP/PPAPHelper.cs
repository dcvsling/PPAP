namespace PPAP
{
    using Entity;
    using ToDo;
    using System;
    /// <summary>
    /// try make script fluent
    /// </summary>
    public static class PPAPHelper
    {
        /// <summary>
        /// let hand can take and throw if stuff on hand 
        /// </summary>
        /// <param name="hand"></param>
        /// <param name="stuff"></param>
        /// <returns></returns>
        public static IHand<TStuff> Take<TStuff>(this IHand hand,Func<TStuff> stuff)
            where TStuff : IStuff
            => (hand as IEmptyHand)?.Take(stuff) ?? throw new Exception("hand have stuff");

        /// <summary>
        /// drop hand's stuff and throw if no stuff on hand what we want
        /// </summary>
        /// <param name="TStuff"></param>
        /// <param name="hand"></param>
        public static (TStuff,IEmptyHand) Drop<TStuff>(this IHand hand)
            where TStuff : IStuff
            => (hand as IHand<TStuff>)?.Drop() ?? throw new Exception($"No {typeof(TStuff).Name} on hand");

        /// <summary>
        /// get PPAP and just dance now!!!~~ PPAP~~~
        /// </summary>
        /// <param name="IHand[IPenPineappleApplePen]"></param>
        /// <param name="ppap"></param>
        /// <param name="output"></param>
        public static void Dance(this (IHand<IPenPineappleApplePen>,IHand<IPenPineappleApplePen>) ppap,Action<string> output)
            => output(ppap.Item1.Stuff.Name);
    }
}
