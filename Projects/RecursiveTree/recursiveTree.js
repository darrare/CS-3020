angle = 0;
prevAngle = 0;
isRandomlyGenerated = false;
function setup() {
  createCanvas(400, 400);
  slider = createSlider(0, TWO_PI, PI / 4, 0.01);
}

function draw() {
  angle = slider.value();
  if (angle != prevAngle)
  {
	   background(51);
	  stroke(255);
	  translate(200, height);

	  branch(100);
	  prevAngle = angle;
  }
  
}
function branch(len) {
  line(0, 0, 0, -len);
  translate(0, -len);
  if (isRandomlyGenerated)
  {
	if (len > 4) {
	push();
	rotate(angle + ((Math.random() - .5) * 2 * angle));
	branch(len * ((Math.random() / 5) + .6));
	pop();
	push();
	rotate(-angle + ((Math.random() - .5) * 2 * angle));
	branch(len * ((Math.random() / 5) + .6));
	pop();
		if (len > 8)
		{
			push();
			rotate(((Math.random() - .5) * 2 * angle));
			branch(len * ((Math.random() / 5) + .6));
			pop();
		}
	}
  }
  else
  {
	if (len > 4) {
		push();
		rotate(angle);
		branch(len * .7);
		pop();
		push();
		rotate(-angle);
		branch(len * .7);
		pop();
		if (len > 16)
		{
			push();
			branch(len * .7);
			pop();
		}
	}
  }

}