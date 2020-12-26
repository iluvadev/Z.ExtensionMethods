﻿using System;
using System.Collections.Generic;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    /// Adds the elements of the specified collection to the end of the <see cref="System.ComponentModel.BindingList{T}"/>,
    /// while only firing the <see cref="System.ComponentModel.BindingList{T}.ListChanged"/>-event once.
    /// </summary>
    /// <typeparam name="T">
    /// The type T of the values of the <see cref="System.ComponentModel.BindingList{T}"/>.
    /// </typeparam>
    /// <param name="bindingList">
    /// The <see cref="System.ComponentModel.BindingList{T}"/> to which the values shall be added.
    /// </param>
    /// <param name="collection">
    /// The collection whose elements should be added to the end of the <see cref="System.ComponentModel.BindingList{T}"/>.
    /// The collection itself cannot be null, but it can contain elements that are null,
    /// if type T is a reference type.
    /// </param>
    /// <exception cref="ArgumentNullException">values is null.</exception>
    public static void AddRange<T>(this System.ComponentModel.BindingList<T> bindingList, IEnumerable<T> collection)
    {
        // The given collection may not be null.
        if (collection == null)
            throw new ArgumentNullException(nameof(collection));

        if (!collection.Any())
            return;

        // Remember the current setting for RaiseListChangedEvents
        // (if it was already deactivated, we shouldn't activate it after adding!).
        var oldRaiseEventsValue = bindingList.RaiseListChangedEvents;

        // Try adding all of the elements to the binding list.
        try
        {
            bindingList.RaiseListChangedEvents = false;

            foreach (var value in collection)
                bindingList.Add(value);
        }

        // Restore the old setting for RaiseListChangedEvents (even if there was an exception),
        // and fire the ListChanged-event once (if RaiseListChangedEvents is activated).
        finally
        {
            bindingList.RaiseListChangedEvents = oldRaiseEventsValue;

            if (bindingList.RaiseListChangedEvents)
                bindingList.ResetBindings();
        }
    }
}