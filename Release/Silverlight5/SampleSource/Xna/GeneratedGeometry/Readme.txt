This is a Silverlight port of the XNA Generated Geometry sample, which 
shows how 3D models can be generated by code during the XNA Content 
Pipeline build process.

The original XNA version is available from:

    http://create.msdn.com/en-US/education/catalog/sample/generated_geometry

This sample uses the XNA Game Studio Content Pipeline to compile 3D models 
and textures into .xnb binary format. This means you must install XNA Game 
Studio 4.0 (in addition to Silverlight) before you can build the Content projects. 
The resulting .xnb files are embedded in the Silverlight .xap 
package from where they can be loaded and drawn by the Silverlight application. 
Because XNA is only used to build this content but not to draw it, Game 
Studio only needs to be installed on your development PC. Users can run 
the resulting application with the standard Silverlight plugin, without 
having to install XNA Game Studio.

The sample renders a simple terrain with a sky behind it. The input data 
consists entirely of textures: a height-field bitmap describing the 
terrain, and a sky bitmap. Custom content pipeline processors convert the 
height-field bitmap into geometry, and generate a skydome mesh for 
rendering the sky texture.

The TerrainProcessor converts an input height-field bitmap into a 3D model 
by using the MeshBuilder helper class provided by XNA. It creates a grid 
of vertices with heights taken from the input bitmap data, and then 
creates triangles connecting these vertices. It creates a material, sets 
this to use the rocks.bmp texture, and applies it to the generated 
terrain. Finally, it chains to the built-in ModelProcessor, so the output 
data can be converted into a suitable run-time format.

The SkyProcessor works in a similar way. It creates a cylinder model, 
wraps the input sky texture around this, and then creates a wrapper Sky 
class that uses a customized projection transform to make sure the sky 
will always be rendered centered on the camera position, and that it will 
be drawn as the most distant thing in the scene behind all other geometry.
