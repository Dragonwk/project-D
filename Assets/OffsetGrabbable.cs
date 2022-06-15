using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class OffsetGrabbable : XRGrabInteractable
{
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        base.OnSelectEntering(args);
        MatchAttachpoint(args.interactor);
    }
    private void MatchAttachpoint(XRBaseInteractor interactor) {
        bool isDirect = interactor is XRDirectInteractor;
        attachTransform.position = isDirect ? interactor.attachTransform.position : transform.position;
        attachTransform.rotation = isDirect ? interactor.attachTransform.rotation : transform.rotation;
    }

}
