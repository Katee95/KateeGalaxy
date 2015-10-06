#region using

using System;
using System.Diagnostics;
using System.Windows;
using Galaxy.Core.Actors;
using Galaxy.Core.Environment;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

#endregion

namespace Galaxy.Environments.Actors
{
  public class Ship2 : Ship
  {
    #region Constant

    private const int MaxSpeed = 3;
    private const long StartFlyMs = 2000;

    #endregion

    #region Private fields

    private bool m_flying;
    private Stopwatch m_flyTimer;

    #endregion

    #region Constructors

    public Ship2(ILevelInfo info):base(info)
    {
      Width = 30;
      Height = 30;
      ActorType = ActorType.Enemy;
    }

    #endregion

      public override void Load()
      {
          InitTimer();
          Load(@"Assets\ship2.png");
      }
  }
}
