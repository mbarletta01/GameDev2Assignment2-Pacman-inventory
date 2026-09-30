using UnityEngine;

namespace PacmanInventory
{
    [RequireComponent(typeof(AudioSource))]
    public class PickupSoundPlayer : MonoBehaviour
    {
        [SerializeField] Inventory m_Inventory;
        [SerializeField] AudioClip m_PickupClip;

        private AudioSource m_Source;

        private void Awake()
        {
            m_Source = GetComponent<AudioSource>();
            m_Source.playOnAwake = false;
        }

        private void OnEnable()
        {
            m_Inventory.ItemAdded += OnItemAdded;
        }

        private void OnDisable()
        {
            if (m_Inventory != null)
                m_Inventory.ItemAdded -= OnItemAdded;
        }

        private void OnItemAdded(Item item)
        {
            m_Source.PlayOneShot(m_PickupClip);
        }
    }
}