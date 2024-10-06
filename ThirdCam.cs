using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // O personagem ou objeto que a câmera seguirá
    public float distance = 5.0f; // Distância da câmera em relação ao personagem
    public float height = 2.0f; // Altura da câmera em relação ao personagem
    public float rotationSpeed = 5.0f; // Velocidade com que a câmera rotaciona ao redor do personagem

    void LateUpdate()
    {
        if (target != null)
        {
            // Calcula a posição desejada da câmera com base na posição do personagem
            Vector3 offset = new Vector3(0, height, -distance);
            Vector3 desiredPosition = target.position + target.TransformDirection(offset);

            // Move a câmera suavemente para a posição desejada usando Lerp (interpolação linear)
            transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * rotationSpeed);

            // Rotaciona a câmera para olhar sempre para o personagem
            transform.LookAt(target.position + Vector3.up * height); // Ajusta a rotação da câmera para sempre olhar para o personagem
        }
    }
}