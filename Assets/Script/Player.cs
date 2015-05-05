using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{


    public enum Updatestate
    {
        normal,
        Turning
    }
    public int angleCount;
    public Updatestate step;
    //public int step;
    public enum Turningtype
    {
        up, down, left, right, none
    }
    public Turningtype type;

    public Vector3 keeppos;

    //public Quaternion keeprotate;
    // Use this for initialization
    void Start()
    {
        step = Updatestate.normal;
        //step = 0;
        type = Turningtype.none;
        angleCount = 0;
        //keeprotate = new Quaternion (0f,0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
		if (menu.mf == false) {

			switch (step) {

			case Updatestate.normal:
				RaycastHit hit;


				bool hoge = false;

				if (Input.GetKeyDown (KeyCode.RightArrow)) {
					if (Physics.Raycast (new Vector3 (transform.position.x, transform.position.y - 0.5f, transform.position.z), Vector3.right, out hit, 1)) {
						type = Turningtype.right;
						//keeppos=this.transform.position.z;
						//keeprotate=this.transform.rotation;

						hoge = true;
						keeppos = new Vector3 (this.transform.position.x + 0.5f, this.transform.position.y, this.transform.position.z);
					}
				}
				if (Input.GetKeyDown (KeyCode.LeftArrow)) {
					//v.x -= 1.0f;
					if (Physics.Raycast (new Vector3 (transform.position.x, transform.position.y - 0.5f, transform.position.z), -Vector3.right, out hit, 1)) {
						hoge = true;
						type = Turningtype.left;
						keeppos = new Vector3 (this.transform.position.x - 0.5f, this.transform.position.y, this.transform.position.z);
						//keeppos=this.transform.position.z;
						//this.transform.Translate (this.transform.right * -1.0f);
					}
				}
				if (Input.GetKeyDown (KeyCode.UpArrow)) {
					//if(Physics.Raycast(new Vector3(transform.position.x,transform.position.y-0.5f,transform.position.z),Vector3.forward,out hit,1)){
					hoge = true;
					type = Turningtype.up;
					//keeppos=transform.position;
					keeppos = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z + 0.5f);
					//GetComponent<Rigidbody>().centerOfMass = new Vector3(this.transform.position.x,this.transform.position.y-0.5f,this.transform.position.z-0.5f);
					//keeppos=this.transform.position.x;
					//}
				}
				if (Input.GetKeyDown (KeyCode.DownArrow)) {
					if (Physics.Raycast (new Vector3 (transform.position.x, transform.position.y - 0.5f, transform.position.z), -Vector3.forward, out hit, 1)) {
						hoge = true;
						type = Turningtype.down;
						keeppos = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z - 0.5f);
						//GetComponent<Rigidbody>().centerOfMass = new Vector3(this.transform.position.x,this.transform.position.y-0.5f,this.transform.position.z+0.5f);

						//keeppos=this.transform.position.x;
					}
				}
				if (hoge == true)
					step = Updatestate.Turning;
                //step++;
				break;

			/*	if(type!=Turningtype.none)
                Turning();*/
			case Updatestate.Turning:

				Turning ();

                //step=Updatestate.normal;
                //step--;
				break;

			}
		}
    }

    public void Turning()
    {


        switch (type)
        {
            case Turningtype.up:
                //this.transform.rotation=Quaternion.AngleAxis(0.02f,f);
                //transform.Rotate(new Vector3(11f,0f,0f));
                //GetComponent<Rigidbody>().angularVelocity =new Vector3(5f,0f,0f);
                //transform.RotateAround(new Vector3 (0,5.15f,1), transform.right, 0.8f);
<<<<<<< HEAD
			transform.position += new Vector3(0f, 0.00f, 0.002f);
                transform.RotateAround(keeppos, transform.right, 10f);

              
=======

                transform.RotateAround(keeppos, transform.right, 10f);

                transform.position += new Vector3(0f, 0.00f, 0.002f);
>>>>>>> origin/matuo
                //transform.position.x=keeppos;
                break;
            case Turningtype.down:
                //this.transform.rotation=Quaternion.AngleAxis(0.02f,f);
                //transform.Rotate(new Vector3(-10f,0f,0f));
                transform.position += new Vector3(0f, 0.000f, -0.002f);
                transform.RotateAround(keeppos, transform.right, -10f);
                //transform.position.x=keeppos;
                break;
            case Turningtype.left:
                //if(Physics.Raycast(transform.position,new Vector3(Vector3.right.x,Vector3.right.y-1f,Vector3.right.z),out hit,-1))
                
                //v.x=-0.01f;
                //v.y=0.0000000001f;
                //this.transform.rotation=Quaternion.AngleAxis(-angleCount+20,f);
                //transform.Rotate(new Vector3(0f,0f,5f));
                transform.position += new Vector3(-0.005f, 0.00f, 0);
			transform.RotateAround(keeppos, transform.forward, 8f);
                //transform.position.z=keeppos;
                ;
                break;
            case Turningtype.right:
                //v.x=0.1f;
                //v.y=0.0001f;
                //this.transform.rotation=Quaternion.AngleAxis(-50f,f);
                //transform.Rotate(new Vector3(0f,0f,-5f));
                transform.position += new Vector3(0.005f, 0.00f, 0);
                //transform.position.z=keeppos;

                transform.RotateAround(keeppos, transform.forward, -8f);
                //iTween.RotateTo(gameObject,iTween.Hash)
                break;
            case Turningtype.none:
                break;



        }
        /*	if (angleCount == 10||type==Turningtype.none) {
                type = Turningtype.none;
                transform.rotation=new Quaternion(0,0,0,0);
                angleCount=0;

                //keeppos=0f;
                //v.x=0;
            }*/
        //transform.position = v;
        //angleCount++;
        //print("col_ente:"+col.gameObject.tag);
    }
    void OnCollisionEnter(Collision col)
    {

        transform.position = new Vector3(Mathf.RoundToInt(transform.position.x),/*transform.position.y-1f*/1f, Mathf.RoundToInt(transform.position.z));
        transform.rotation = new Quaternion(0, 0, 0, 0);
        type = Turningtype.none;

        step = Updatestate.normal;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        keeppos = Vector3.zero;
        print("col_enter:" + col.gameObject.tag);
        if (GetComponent<Rigidbody>().velocity == Vector3.zero)
            print("******:" + col.gameObject.tag);
    }


};
