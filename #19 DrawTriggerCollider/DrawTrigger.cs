using UnityEngine;

public class DrawTrigger : MonoBehaviour
{
	//В этом поле указывайте цвет вашей гизмо
	//Не забудьте поправить Alpha в инспекторе, чтобы гизмо стал видимым (невидимый по умолчанию)
	[SerializeField] private Color _myColor;

	//Вместо этого метода вы можете использовать OnDrawGizmosSelected
    //Для отрисовки коллайдера только если объект выбран
    //Также вы можете самостоятельно заменить куб на сферу или меш колайдер. Подробнее в документации по Gizmos
  
    private void OnDrawGizmos()
    {
	    Debug.Log("Draw");
    	Gizmos.color = _myColor;
        
        //Размер гизмо не зависит от размера коллайдера
        //Только от размеров самого объекта (в том числе от его позиции и разворота)
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);    
    }
}
