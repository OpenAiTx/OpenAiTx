## Shape Key Tools for Blender
<!-- BADGES/ -->
<span class="badge-blenderartists"><a href="https://blenderartists.org/t/free-shape-key-transfer-addon" title="Link to Blender Artists forum post"><img src="https://img.shields.io/badge/Blender-Artists-orange.svg?logo=blender&longCache=true&style=popout-square" alt="Blender Artists Forum Post" /></a></span>
<span class="badge-discord"><a href="https://discord.gg/CmgdEvw" title="Join on discord"><img src="https://img.shields.io/badge/Discord-Join-768ADC.svg?logo=discord&longCache=true&style=popout-square" alt="Discord server button" /></a></span>
<span class="badge-youtube"><a href="https://www.youtube.com/watch?v=-zBlaedkkVs" title="Watch Tutorial on Youtube"><img src="https://img.shields.io/badge/Tutorial-Video-F40000.svg?logo=youtube&longCache=true&style=popout-square" alt="Youtube Tutorial" /></a></span>

Shape Key Transfer for Blender 2.93

Use this addon to easily transfer shape keys between meshes of different topology.

Place both the meshes at origin and overlap them at the location you want the destination mesh to copy shape keys of the source mesh.

This addon was initially created to copy shape keys from ManuelBastioniLab Character to other meshes, but can be used in any situation.

This addon is based on the code within this [StackoverFlow post](https://blender.stackexchange.com/questions/119836/scripting-transferring-shape-keys-between-different-meshes/119867#119867) made by me.

The addon will be under Tools -> Shape Key Tools

You can exclude shape keys also.

Use Increment Radius to increase the number of vertices from the source mesh which affect the destination mesh.

When Use Closest Vertex is off it will average the locations of all nearby vertices within the Increment Radius.

#### Fewer vertices in the source mesh will make the operation run faster.

##

### Features:

- Transfer Shape Keys between meshes of different topologies

- Manage what shape keys are transferred by adding exclusions

- Copy all shape key names of a mesh to clipboard

### Example Use Cases:

- Copy shape keys from face to moustache or eyebrow hair cards.

- Copy shape keys from base mesh to LOD.

##

### Note:
Sometimes it is good to duplicate the source mesh and remove the vertices you feel may not be required to affect the destination mesh. 

One example incase of a moustache and a face: Duplicate the face and delete all the vertices except the ones around the lips which are most likely to influence the moustache and use the resulting mesh as source to copy shape keys to your destination moustache hair cards or mesh.

Will be adding more functionality to this addon if required. You can also delete all shape keys in a mesh easily with this tool.

##

### License:

Shape Key Transfer Addon for Blender - Copyright (C) 2018 Ajit Christopher D'Monte

All python files are released under GNU General Public License 3.
