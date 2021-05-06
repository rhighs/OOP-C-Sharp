using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cov_sim
{
    public class Person
    {
        private bool infected = false;
        private Mask mask;


        public Person(Mask.Protection protection)
        {

            this.mask = new Mask(protection, Mask.Status.UP);
        }

        public bool isInfected()
        {
            return infected;
        }

        public Mask getMask()
        {
            return mask;
        }

        public void maskDown()
        {
            mask.setStatus(Mask.Status.DOWN);
        }

        public void switchMaskState()
        {
            mask.setStatus(mask.getStatus() == Mask.Status.UP ? Mask.Status.DOWN : Mask.Status.UP);
        }

        public class Mask
        {
            private Protection protection;
            private Status status;

            /**
             * @param protection
             * @param status
             */
            public Mask(Protection protection, Status status)
            {
                this.status = status;
                this.protection = protection;
            }

            /**
             * Returns the status of the mask.
             */
            public Status getStatus()
            {
                return status;
            }

            public void setStatus(Status status)
            {
                this.status = status;
            }

            /**
             * Return the mask protection.
             */
            public Protection getProtection()
            {
                return protection;
            }

            public enum Status
            {
                UP,
                DOWN
            }

            public enum Protection
            {
                FP1,
                FP2,
                FP3,
            }
        }
    }

}
