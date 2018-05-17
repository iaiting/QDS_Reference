using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QDSCSharpSDK
{
    public class QDSApiCallbackBase
    {
        virtual public void OnSubscribe_SSEL2_Static(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SSEL2_Quotation(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SSEL2_Index(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SSEL2_Transaction(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SSEL2_Auction(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SSEL2_Overview(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SZSEL2_Static(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SZSEL2_Quotation(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SZSEL2_Status(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SZSEL2_Index(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SZSEL2_Order(IntPtr RealValuePtr) { }

        virtual public void OnSubscribe_SZSEL2_Transaction(IntPtr RealValuePtr) { }
    }


    
}
