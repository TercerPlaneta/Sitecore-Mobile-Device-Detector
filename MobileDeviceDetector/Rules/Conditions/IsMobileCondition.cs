﻿namespace Sitecore.SharedSource.MobileDeviceDetector.Rules.Conditions
{
  using Sitecore.Rules;

  /// <summary>
  /// IsMobileCondition
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public class IsMobileCondition<T> : BooleanPropertyCondition<T> where T : RuleContext
  {
    public IsMobileCondition()
    {
      this.Value = "IsMobile";
    }
  }
}
