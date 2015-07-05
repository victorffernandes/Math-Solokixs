using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeControler : MonoBehaviour {

    public int playTime = 0;
    public int minutes = 0;
    public int seconds = 0;
    public int hours = 0;
    public int days = 0;
    public GameObject button;

	void Start ()
    {
        Time.timeScale = 0;
        this.button = GameObject.Find("ButtonTry");
	}

    public void BeginTime()
    {
       StartCoroutine(PlayTimer());
       if (this.name.Equals("Time"))
       { this.button.SetActive(false); }
       Time.timeScale = 1;
    }

    IEnumerator PlayTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            this.playTime += 1;
            this.seconds = (playTime % 60);
            this.minutes = (playTime / 60) % 60;
            this.hours = (playTime / 3600) % 24;
            this.days = (playTime / 86400) % 365;
        }
    }

	void FixedUpdate () 
    {
        if (this.name.Equals("Time"))
        { this.GetComponent<Text>().text = seconds.ToString() + "/" + 60; }

        if(this.seconds > 59)
        { Debug.Log("perdeu"); }

        Debug.Log("Segundos: " + seconds.ToString() + "  " + "Minutos" + minutes.ToString());
	}
}
