using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public List<Box> boxes = new List<Box>();

    public GameObject vfxCompleted;

    public void AddBox(Box box)
    {
        if (!boxes.Contains(box))
        {
            boxes.Add(box);

            if (boxes.Count == 2)
            {

                foreach(Box box_obj in boxes)
                {
                    GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].gameObjects.Remove(box_obj.gameObject);
                    box_obj.gameObject.SetActive(false);
                }

                GameObject vfx = Instantiate(vfxCompleted, transform.position, Quaternion.identity) as GameObject;
                Destroy(vfx, 1f);

                boxes.Clear();

                GameManager.Instance.CheckLevelUp();
            }
        }
    }
}
