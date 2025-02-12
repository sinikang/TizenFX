/*
 * Copyright(c) 2019 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

namespace Tizen.NUI
{
    internal class PropertyRegistration : Disposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal PropertyRegistration(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PropertyRegistration obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    Interop.NDalic.delete_PropertyRegistration(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }


        public PropertyRegistration(TypeRegistration registered, string name, int index, PropertyType type, SWIGTYPE_p_f_p_Dali__BaseObject_int_r_q_const__Dali__Property__Value__void setFunc, SWIGTYPE_p_f_p_Dali__BaseObject_Dali__Property__Index__Dali__Property__Value getFunc) : this(Interop.NDalic.new_PropertyRegistration(TypeRegistration.getCPtr(registered), name, index, (int)type, SWIGTYPE_p_f_p_Dali__BaseObject_int_r_q_const__Dali__Property__Value__void.getCPtr(setFunc), SWIGTYPE_p_f_p_Dali__BaseObject_Dali__Property__Index__Dali__Property__Value.getCPtr(getFunc)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }
    }
}
