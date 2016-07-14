/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Qualcomm Connected Experiences, Inc.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
	/// 
	/// 
    public class DefaultTrackableEventHandler : MonoBehaviour,
                                                ITrackableEventHandler
    {
		
		public GameObject u,o,a,k,d,n,s,c;
        #region PRIVATE_MEMBER_VARIABLES
 
        private TrackableBehaviour mTrackableBehaviour;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(
                                        TrackableBehaviour.Status previousStatus,
                                        TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

			if(mTrackableBehaviour.TrackableName=="soha"){
				//Debug.Log ("angel priya");
				s.SetActive (true);
				u.SetActive (false);
				a.SetActive (false);
				k.SetActive (false);
				d.SetActive (false);
				n.SetActive (false);
				c.SetActive (false);
				o.SetActive (false);

			}
			 if(mTrackableBehaviour.TrackableName=="kholi"){
				s.SetActive (false);
				u.SetActive (false);
				a.SetActive (false);
				k.SetActive (true);
				d.SetActive (false);
				n.SetActive (false);
				c.SetActive (false);
				o.SetActive (false);
			}
			 if(mTrackableBehaviour.TrackableName=="uk"){
				s.SetActive (false);
				u.SetActive (true);
				a.SetActive (false);
				k.SetActive (false);
				d.SetActive (false);
				n.SetActive (false);
				c.SetActive (false);
				o.SetActive (false);
			}	 if(mTrackableBehaviour.TrackableName=="obama"){
				s.SetActive (false);
				u.SetActive (false);
				a.SetActive (false);
				k.SetActive (false);
				d.SetActive (false);
				n.SetActive (false);
				c.SetActive (false);
				o.SetActive (true);
			}	else if(mTrackableBehaviour.TrackableName=="amma"){
				s.SetActive (false);
				u.SetActive (false);
				a.SetActive (true);
				k.SetActive (false);
				d.SetActive (false);
				n.SetActive (false);
				c.SetActive (false);
				o.SetActive (false);
			}	else if(mTrackableBehaviour.TrackableName=="david"){
				s.SetActive (false);
				u.SetActive (false);
				a.SetActive (false);
				k.SetActive (false);
				d.SetActive (true);
				n.SetActive (false);
				c.SetActive (false);
				o.SetActive (false);
			}	else if(mTrackableBehaviour.TrackableName=="noida"){
				s.SetActive (false);
				u.SetActive (false);
				a.SetActive (false);
				k.SetActive (false);
				d.SetActive (false);
				n.SetActive (true);
				c.SetActive (false);
				o.SetActive (false);
			}	else if(mTrackableBehaviour.TrackableName=="closeup"){
				s.SetActive (false);
				u.SetActive (false);
				a.SetActive (false);
				k.SetActive (false);
				d.SetActive (false);
				n.SetActive (false);
				c.SetActive (true);
				o.SetActive (false);
			}
        }


        private void OnTrackingLost()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
        }

        #endregion // PRIVATE_METHODS
    }
}
