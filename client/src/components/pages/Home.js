import React from "react";

const Home = () => (
  <div className="webgl-content">
  <div id="gameContainer" ></div>
  <div className="footer">
    <div className="webgl-logo"></div>
    <div className="fullscreen" onClick={window.gameInstance.SetFullscreen(1)}></div>
    <div className="title">Word Typing Game</div>
  </div>
</div>
);

export default Home;
