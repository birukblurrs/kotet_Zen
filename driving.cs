using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driving : MonoBehaviour

{
     [SerializeField]
    float steerangle;

    [SerializeField]
    float movespeed;
     [SerializeField]
    float maxSpeed;
    [SerializeField]
    float drag=0.98f;
    Vector3 moveForce;
    public float traction=1;
    public float circleDrawtime;
    public float circletimemax;
   public GameObject rightPowerUp;
   
   public GameObject rightPowerUpPoint;
   public GameObject leftPowerUp;
    public GameObject leftPowerUpPoint;
    public GameObject puzzleSKidmarks;
    public float puzzleWeartime;
    public float PuzzleTimeMAX;
    bool puzzleActivated;
        // Start is called before the first frame update
    void Start()
    {
        puzzleWeartime=0f;
     puzzleSKidmarks.SetActive(false);
    }

    // Update is called once per frame
    
    void FixedUpdate()

    {
        float forwards=Input.GetAxis("Vertical");
        
        float sideturn=Input.GetAxis("Horizontal");
        int y=Mathf.RoundToInt(forwards);
        int x=Mathf.RoundToInt(sideturn);

        //forward drive
        moveForce+=transform.forward*movespeed*Input.GetAxis("Vertical")*Time.deltaTime;
        //steer input
        float steerInput=Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up*steerInput*moveForce.magnitude*steerangle*Time.deltaTime);
        transform.position+=moveForce*Time.deltaTime;
        //drag
        moveForce*=drag*Time.deltaTime;
        
        //traction
        Debug.DrawRay(transform.position,moveForce.normalized*3,Color.red);
        Debug.DrawRay(transform.position,transform.forward*3,Color.blue);
        moveForce=Vector3.Lerp(moveForce.normalized,transform.forward,traction*Time.deltaTime)*moveForce.magnitude;
    }

 private void Update() {
      if(puzzleActivated){
            puzzleWeartime+=Time.deltaTime;
        }
         if(puzzleWeartime>=PuzzleTimeMAX){
        puzzleActivated=false;
       puzzleSKidmarks.SetActive(false);
       puzzleWeartime=0f;
   }

        if(Input.GetAxis("Vertical")==1&&Input.GetAxis("Horizontal")==1){
            circleDrawtime+=Time.deltaTime;
            if(circleDrawtime>circletimemax){
               
                circleDrawtime=0f;
                     createRight();

            }
            
        }
       
        
        
          else if(Input.GetAxis("Vertical")==1&&Input.GetAxis("Horizontal")==-1){
                   
            circleDrawtime+=Time.deltaTime;
          
            if(circleDrawtime>circletimemax){
             
                circleDrawtime=0f;
                 
                  createLeft();

                   
            }   
        }
        else{
                circleDrawtime=0f;
                
            }



}

void createRight(){
    Instantiate(rightPowerUp,rightPowerUpPoint.transform.position,Quaternion.identity);

}
void createLeft(){
    Instantiate(leftPowerUp,leftPowerUpPoint.transform.position,Quaternion.identity);
    puzzleActivated=true;
   if(puzzleWeartime<PuzzleTimeMAX){
        puzzleSKidmarks.SetActive(true);
   }
  
   
  
}
/*IEnumerator powerWearoff(){
    yield return new WaitForSeconds(puzzleWeartime*Time.deltaTime);
    puzzleSKidmarks.SetActive(false);
}*/

}
