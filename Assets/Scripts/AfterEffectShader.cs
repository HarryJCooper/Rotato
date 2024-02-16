using UnityEngine;

[ExecuteInEditMode, RequireComponent(typeof(Camera))]
public class AfterEffectShader : MonoBehaviour {
    public Shader effectShader;
    private Material effectMaterial;

    void Start() {
        if (effectShader != null) {
            effectMaterial = new Material(effectShader);
        } else {
            Debug.LogError("Shader not assigned.", this);
        }
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest) {
        if (effectMaterial != null) {
            Graphics.Blit(src, dest, effectMaterial);
        } else {
            Graphics.Blit(src, dest);
        }
    }
}
