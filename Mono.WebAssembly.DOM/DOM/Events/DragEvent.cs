using System;
using Mono.WebAssembly;

namespace Mono.WebAssembly.DOM.Events
{

    [Export("DragEvent", typeof(Mono.WebAssembly.JSObject))]
    public sealed class DragEvent : MouseEvent
    {
        internal DragEvent(int handle) : base(handle) { }

        //public DragEvent(object type, object dragEventInit) { }
        DataTransfer dataTransfer;
        [Export("dataTransfer")]
        public DataTransfer DataTransfer { 
            get
            {
                if (dataTransfer == null)
                    dataTransfer = GetProperty<DataTransfer>("dataTransfer");
                return dataTransfer;
            }
            set => SetProperty<DataTransfer>("dataTransfer", value); 
        }
        //[Export("initDragEvent")]
        //public void InitDragEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Window viewArg, double detailArg, double screenXArg, double screenYArg, double clientXArg, double clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, double buttonArg, EventTarget relatedTargetArg, IDataTransfer dataTransferArg)
        //{
        //    InvokeMethod<object>("initDragEvent", typeArg, canBubbleArg, cancelableArg, viewArg, detailArg, screenXArg, screenYArg, clientXArg, clientYArg, ctrlKeyArg, altKeyArg, shiftKeyArg, metaKeyArg, buttonArg, relatedTargetArg, dataTransferArg);
        //}
        //[Export("msConvertURL")]
        //public void MsConvertUrl(File file, string targetType, string targetURL)
        //{
        //    InvokeMethod<object>("msConvertURL", file, targetType, targetURL);
        //}
    }

}