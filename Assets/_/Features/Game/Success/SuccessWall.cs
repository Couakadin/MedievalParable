using UnityEngine;

namespace Game.Runtime
{
    public class SuccessWall : SuccessAbstract
    {
        #region Publics

        #endregion

        #region Unity



        #endregion

        #region Methods

        protected override void OnSuccess()
        {
            Debug.Log("Success");
        }

        protected override void OnFailure()
        {
            Debug.Log("Failure");
        }

        #endregion

        #region Utils

        #endregion

        #region Privates

        #endregion
    }
}
