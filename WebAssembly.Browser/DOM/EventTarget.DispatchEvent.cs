﻿using System;
namespace WebAssembly.Browser.DOM
{
    public partial class EventTarget
    {

        public void DispatchDOMEvent(string type, string typeOfEvent, string UID, JSObject eventHandle, string eventInfo = null)
        {

            #if DEBUG
            //Console.WriteLine($"EventType: {type} TypeOfEvent: {typeOfEvent}, Event Id: {UID}, Event Handle: {eventHandle}, Event Info: {eventInfo}");
            #endif

            var eventArgs = new DOMEventArgs(this, type, typeOfEvent, eventHandle, eventInfo);


            lock (eventHandlers)
            {
                DOMEventHandler eventHandler;
                if (eventHandlers.TryGetValue(type, out eventHandler))
                {
                    eventHandler?.Invoke(this, eventArgs);
                }
            }

            eventArgs.EventObject?.Dispose();
            eventArgs.EventObject = null;
            eventArgs.Source = null;
            eventArgs = null;
        }
    }
}
