using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class laser : MonoBehaviour
{
    // lineRender is the beam, laserPoint is the end of the laser

    private LineRenderer lineRenderer;
    public Transform laserTip;
    Rigidbody2D meteorite;
    // public GameObject meteor;
    // public Transform MeteorPos;
    // public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        // attaches the lineRenderer variable with line renderer component in unity
        // set the laser to off by default and where to draw on the game screen
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
        lineRenderer.useWorldSpace = true;
        // meteorite = GetComponent<Rigidbody2D>();
        // target.position = WordManager.Word.position;
    }

    // Update is called once per frame
    void Update()
    {
        // player = GameObject.FindGameObjectWithTag("Player");
        // meteor.position = target.position;
        // meteor = GameObject.FindGameObjectWithTag("target");
        // MeteorPos.transform.position = meteor.transform.position;
        // var target = GameObject.FindGameObjectWithTag("meteor").transform.position;
        // Console.WriteLine(meteor.transform.position);
        // uses raycast to draw the laser pointing up
        RaycastHit2D tag = Physics2D.Raycast(transform.position, transform.up);
        //draw a line to test laser path
        Debug.DrawLine(transform.position, tag.point);
        //sets the laser end to where ever the ray touches a physics object
        laserTip.position = tag.point;
        // set origin point for laser
        lineRenderer.SetPosition(0, transform.position);
        //set end point for laser
        lineRenderer.SetPosition(1, laserTip.position);
        // FIRE THE LASER!
        if (Input.anyKey)
        {
            lineRenderer.enabled = true;
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }
}
