using TMPro;
using UnityEngine;

namespace PacmanInventory
{
    public class InventoryUI : MonoBehaviour
    {
        [SerializeField] Inventory m_Inventory;
        [SerializeField] TMP_Text m_Label;

        private void OnEnable()
        {
            m_Inventory.InventoryChanged += Refresh;
            Refresh();
        }

        private void OnDisable()
        {
            if (m_Inventory != null)
                m_Inventory.InventoryChanged -= Refresh;
        }

        private void Refresh()
        {
            m_Label.text =
                "INVENTORY\n" +
                $"Score Pellets: {m_Inventory.GetCount("Score Pellet")}\n" +
                $"Power Ups: {m_Inventory.GetCount("Power Up")}\n" +
                $"Total Items: {m_Inventory.GetCount()}";
        }
    }
}