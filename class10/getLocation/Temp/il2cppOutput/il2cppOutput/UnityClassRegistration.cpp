template <typename T> void RegisterClass();
template <typename T> void RegisterStrippedTypeInfo(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_CloudWebServices();
	RegisterModule_CloudWebServices();

	void RegisterModule_ParticleSystem();
	RegisterModule_ParticleSystem();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_GameCenter();
	RegisterModule_GameCenter();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_ImageConversion();
	RegisterModule_ImageConversion();

}

class EditorExtension; template <> void RegisterClass<EditorExtension>();
namespace Unity { class Component; } template <> void RegisterClass<Unity::Component>();
class Behaviour; template <> void RegisterClass<Behaviour>();
class Animation; 
class Animator; template <> void RegisterClass<Animator>();
class AudioBehaviour; template <> void RegisterClass<AudioBehaviour>();
class AudioListener; template <> void RegisterClass<AudioListener>();
class AudioSource; 
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterClass<Camera>();
namespace UI { class Canvas; } template <> void RegisterClass<UI::Canvas>();
namespace UI { class CanvasGroup; } template <> void RegisterClass<UI::CanvasGroup>();
namespace Unity { class Cloth; } 
class Collider2D; 
class BoxCollider2D; 
class CapsuleCollider2D; 
class CircleCollider2D; 
class CompositeCollider2D; 
class EdgeCollider2D; 
class PolygonCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; template <> void RegisterClass<FlareLayer>();
class GUIElement; 
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterClass<GUILayer>();
class Halo; 
class HaloLayer; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; template <> void RegisterClass<Light>();
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterClass<MonoBehaviour>();
class NavMeshAgent; 
class NavMeshObstacle; 
class NetworkView; 
class OffMeshLink; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; 
class Skybox; 
class SortingGroup; 
class Terrain; 
class VideoPlayer; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterClass<UI::CanvasRenderer>();
class Collider; template <> void RegisterClass<Collider>();
class BoxCollider; template <> void RegisterClass<BoxCollider>();
class CapsuleCollider; template <> void RegisterClass<CapsuleCollider>();
class CharacterController; 
class MeshCollider; template <> void RegisterClass<MeshCollider>();
class SphereCollider; template <> void RegisterClass<SphereCollider>();
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterClass<MeshFilter>();
class OcclusionArea; 
class OcclusionPortal; 
class ParticleAnimator; 
class ParticleEmitter; 
class EllipsoidParticleEmitter; 
class MeshParticleEmitter; 
class ParticleSystem; template <> void RegisterClass<ParticleSystem>();
class Renderer; template <> void RegisterClass<Renderer>();
class BillboardRenderer; 
class LineRenderer; 
class MeshRenderer; template <> void RegisterClass<MeshRenderer>();
class ParticleRenderer; 
class ParticleSystemRenderer; 
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; 
class TrailRenderer; 
class Rigidbody; 
class Rigidbody2D; 
namespace TextRenderingPrivate { class TextMesh; } template <> void RegisterClass<TextRenderingPrivate::TextMesh>();
class Transform; template <> void RegisterClass<Transform>();
namespace UI { class RectTransform; } template <> void RegisterClass<UI::RectTransform>();
class Tree; 
class WorldAnchor; 
class WorldParticleCollider; 
class GameObject; template <> void RegisterClass<GameObject>();
class NamedObject; template <> void RegisterClass<NamedObject>();
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class StyleSheetImporter; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; 
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterClass<TextRendering::Font>();
class GameObjectRecorder; 
class LightProbes; template <> void RegisterClass<LightProbes>();
class Material; template <> void RegisterClass<Material>();
class ProceduralMaterial; 
class Mesh; template <> void RegisterClass<Mesh>();
class Motion; 
class AnimationClip; 
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; template <> void RegisterClass<PhysicMaterial>();
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterClass<PreloadData>();
class RuntimeAnimatorController; 
class AnimatorController; 
class AnimatorOverrideController; 
class SampleClip; template <> void RegisterClass<SampleClip>();
class AudioClip; template <> void RegisterClass<AudioClip>();
class Shader; template <> void RegisterClass<Shader>();
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterClass<Sprite>();
class SpriteAtlas; 
class SubstanceArchive; 
class TerrainData; 
class TextAsset; template <> void RegisterClass<TextAsset>();
class CGProgram; 
class MonoScript; template <> void RegisterClass<MonoScript>();
class Texture; template <> void RegisterClass<Texture>();
class BaseVideoTexture; 
class MovieTexture; 
class WebCamTexture; 
class CubemapArray; 
class LowerResBlitTexture; template <> void RegisterClass<LowerResBlitTexture>();
class ProceduralTexture; 
class RenderTexture; template <> void RegisterClass<RenderTexture>();
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterClass<Texture2D>();
class Cubemap; template <> void RegisterClass<Cubemap>();
class Texture2DArray; template <> void RegisterClass<Texture2DArray>();
class Texture3D; template <> void RegisterClass<Texture3D>();
class VideoClip; 
class GameManager; template <> void RegisterClass<GameManager>();
class GlobalGameManager; template <> void RegisterClass<GlobalGameManager>();
class AudioManager; template <> void RegisterClass<AudioManager>();
class BuildSettings; template <> void RegisterClass<BuildSettings>();
class CloudWebServicesManager; template <> void RegisterClass<CloudWebServicesManager>();
class CrashReportManager; 
class DelayedCallManager; template <> void RegisterClass<DelayedCallManager>();
class GraphicsSettings; template <> void RegisterClass<GraphicsSettings>();
class InputManager; template <> void RegisterClass<InputManager>();
class MasterServerInterface; template <> void RegisterClass<MasterServerInterface>();
class MonoManager; template <> void RegisterClass<MonoManager>();
class NavMeshProjectSettings; 
class NetworkManager; template <> void RegisterClass<NetworkManager>();
class PerformanceReportingManager; 
class Physics2DSettings; 
class PhysicsManager; template <> void RegisterClass<PhysicsManager>();
class PlayerSettings; template <> void RegisterClass<PlayerSettings>();
class QualitySettings; template <> void RegisterClass<QualitySettings>();
class ResourceManager; template <> void RegisterClass<ResourceManager>();
class RuntimeInitializeOnLoadManager; template <> void RegisterClass<RuntimeInitializeOnLoadManager>();
class ScriptMapper; template <> void RegisterClass<ScriptMapper>();
class TagManager; template <> void RegisterClass<TagManager>();
class TimeManager; template <> void RegisterClass<TimeManager>();
class UnityAnalyticsManager; 
class UnityConnectSettings; template <> void RegisterClass<UnityConnectSettings>();
class LevelGameManager; template <> void RegisterClass<LevelGameManager>();
class LightmapSettings; template <> void RegisterClass<LightmapSettings>();
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterClass<RenderSettings>();
class NScreenBridge; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 70 non stripped classes
	//0. Behaviour
	RegisterClass<Behaviour>();
	//1. Unity::Component
	RegisterClass<Unity::Component>();
	//2. EditorExtension
	RegisterClass<EditorExtension>();
	//3. Camera
	RegisterClass<Camera>();
	//4. GameObject
	RegisterClass<GameObject>();
	//5. RenderSettings
	RegisterClass<RenderSettings>();
	//6. LevelGameManager
	RegisterClass<LevelGameManager>();
	//7. GameManager
	RegisterClass<GameManager>();
	//8. MeshFilter
	RegisterClass<MeshFilter>();
	//9. Renderer
	RegisterClass<Renderer>();
	//10. LightProbes
	RegisterClass<LightProbes>();
	//11. NamedObject
	RegisterClass<NamedObject>();
	//12. LightmapSettings
	RegisterClass<LightmapSettings>();
	//13. GUILayer
	RegisterClass<GUILayer>();
	//14. Light
	RegisterClass<Light>();
	//15. Mesh
	RegisterClass<Mesh>();
	//16. MonoBehaviour
	RegisterClass<MonoBehaviour>();
	//17. Shader
	RegisterClass<Shader>();
	//18. Material
	RegisterClass<Material>();
	//19. Sprite
	RegisterClass<Sprite>();
	//20. Texture
	RegisterClass<Texture>();
	//21. Texture2D
	RegisterClass<Texture2D>();
	//22. RenderTexture
	RegisterClass<RenderTexture>();
	//23. Transform
	RegisterClass<Transform>();
	//24. UI::RectTransform
	RegisterClass<UI::RectTransform>();
	//25. ParticleSystem
	RegisterClass<ParticleSystem>();
	//26. Collider
	RegisterClass<Collider>();
	//27. BoxCollider
	RegisterClass<BoxCollider>();
	//28. SphereCollider
	RegisterClass<SphereCollider>();
	//29. MeshCollider
	RegisterClass<MeshCollider>();
	//30. CapsuleCollider
	RegisterClass<CapsuleCollider>();
	//31. AudioClip
	RegisterClass<AudioClip>();
	//32. SampleClip
	RegisterClass<SampleClip>();
	//33. Animator
	RegisterClass<Animator>();
	//34. TextRenderingPrivate::TextMesh
	RegisterClass<TextRenderingPrivate::TextMesh>();
	//35. TextRendering::Font
	RegisterClass<TextRendering::Font>();
	//36. UI::Canvas
	RegisterClass<UI::Canvas>();
	//37. UI::CanvasGroup
	RegisterClass<UI::CanvasGroup>();
	//38. UI::CanvasRenderer
	RegisterClass<UI::CanvasRenderer>();
	//39. MeshRenderer
	RegisterClass<MeshRenderer>();
	//40. PreloadData
	RegisterClass<PreloadData>();
	//41. Cubemap
	RegisterClass<Cubemap>();
	//42. Texture3D
	RegisterClass<Texture3D>();
	//43. Texture2DArray
	RegisterClass<Texture2DArray>();
	//44. LowerResBlitTexture
	RegisterClass<LowerResBlitTexture>();
	//45. MonoScript
	RegisterClass<MonoScript>();
	//46. TextAsset
	RegisterClass<TextAsset>();
	//47. NetworkManager
	RegisterClass<NetworkManager>();
	//48. GlobalGameManager
	RegisterClass<GlobalGameManager>();
	//49. AudioManager
	RegisterClass<AudioManager>();
	//50. PhysicsManager
	RegisterClass<PhysicsManager>();
	//51. PlayerSettings
	RegisterClass<PlayerSettings>();
	//52. BuildSettings
	RegisterClass<BuildSettings>();
	//53. InputManager
	RegisterClass<InputManager>();
	//54. RuntimeInitializeOnLoadManager
	RegisterClass<RuntimeInitializeOnLoadManager>();
	//55. TimeManager
	RegisterClass<TimeManager>();
	//56. TagManager
	RegisterClass<TagManager>();
	//57. GraphicsSettings
	RegisterClass<GraphicsSettings>();
	//58. CloudWebServicesManager
	RegisterClass<CloudWebServicesManager>();
	//59. DelayedCallManager
	RegisterClass<DelayedCallManager>();
	//60. QualitySettings
	RegisterClass<QualitySettings>();
	//61. ResourceManager
	RegisterClass<ResourceManager>();
	//62. MonoManager
	RegisterClass<MonoManager>();
	//63. MasterServerInterface
	RegisterClass<MasterServerInterface>();
	//64. ScriptMapper
	RegisterClass<ScriptMapper>();
	//65. UnityConnectSettings
	RegisterClass<UnityConnectSettings>();
	//66. AudioBehaviour
	RegisterClass<AudioBehaviour>();
	//67. AudioListener
	RegisterClass<AudioListener>();
	//68. FlareLayer
	RegisterClass<FlareLayer>();
	//69. PhysicMaterial
	RegisterClass<PhysicMaterial>();

}
