var frames : Texture[];
 var framesPerSecond = 10;
 var t = 0f;

  function Update() 
  {
  t = t + Time.deltaTime;
   var index : int = (t * framesPerSecond) % frames.Length;
   GetComponent.<Renderer>().material.mainTexture = frames[index];
    }