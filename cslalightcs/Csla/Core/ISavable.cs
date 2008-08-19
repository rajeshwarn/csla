using System;

namespace Csla.Core
{
  /// <summary>
  /// Specifies that the object can save
  /// itself.
  /// </summary>
  public interface ISavable
  {
    /// <summary>
    /// Saves the object to the database asynchronously. The saved event will contain
    /// the new object when the save operation completes.
    /// </summary>
    void BeginSave();
    /// <summary>
    /// INTERNAL CSLA .NET USE ONLY.
    /// </summary>
    /// <param name="newObject">
    /// The new object returned as a result of the save.
    /// </param>
    void SaveComplete(object newObject, Exception error);
    /// <summary>
    /// Event raised when an object has been saved.
    /// </summary>
    event EventHandler<SavedEventArgs> Saved;
  }
}