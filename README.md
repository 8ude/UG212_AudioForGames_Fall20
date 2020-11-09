# UG212_AudioForGames_Fall20
Fall 2020 Repository for Audio for Digital Games at NYU!

WEEK 11 ASSIGNMENT - MUSIC
------

Due Sunday, Nov 16 at 11:59 pm

Pick a screenshot or box art from [HERE](https://drive.google.com/open?id=12qiPQRp3esnnQXWAuZJFnsE81Eehc0lp) as a point of inspiration!  You can find your own, but it will help if you don't already know the music!

Make 2 sections of music - think of them as an "A section" and a "B section."  Here's a [Sample Reaper Project with some instruments set up](https://drive.google.com/file/d/1T7Pv7u1g1VZosPoHqLuHV9vSawDRu1ma/view?usp=sharing). If you don't like working in Reaper, I recommend trying something like [Bosca Ceoil](https://boscaceoil.net/) or [BandLab](https://www.bandlab.com/)

You can make use of some of the apps and plugins on the [Musical Resources Page](https://github.com/8ude/UG212_AudioForGames_Fall20/wiki/Music-Making-Resources)

Upload your music [HERE](https://drive.google.com/drive/folders/1ReWFe7dGmDdIjIyP2a-QSjfD_tKtZZT_?usp=sharing)


WEEK 10 ASSIGNMENT - 3D SOUNDSPACE
------
Due Sunday, Nov 8 at 11:59 pm

Using Resonance Audio and Unity, create a sonic environment/walking simulator/sound installation that makes use of the following:

- At least 5 audio sources that make use of the resonance audio features (directionality, occlusion, etc)
- At least 3 distinct reverb spaces

Additionally, I encourage you to try to make an ambisonic loop (not required).  I'll post a video on how to make one.

I recommend starting from the ResonanceAudioDemo scene in the unity package.

[Upload your builds here](https://drive.google.com/drive/folders/14U62NOPeFEZeQHd_g7vL8bCA1fH9Apr7?usp=sharing)

WEEK 7-9 ASSIGNMENT - 3D RESKIN
------
The SampleFPS project is filled with placeholder sounds, and needs new audio!  Clone the repo, open the SampleFPS project in both Unity and FMOD, and replace the audio.

There will be a **progress check on October 26** - aim for about half of the sounds in the game.  Builds will be due at **11:59 pm on Sunday, Nov 1st**.  Upload them [HERE](https://drive.google.com/drive/folders/1QucPB_Ulop333bOMalsAyMtIJWgIYAYM?usp=sharing)

A lot of the work is going to be done in FMOD studio.  You may need to work in Unity a bit to make more emitters for your ambiences, or to code additional parameters if you choose.

I challenge you to work within some constraints to transform the feel of this game through sound.  Maybe work with a small set of samples, or try doing the entire ReSkin from sounds that you record yourself.  It's abstract enough that we could imagine that the robots are really any kind of antagonist.  

I'm essentially looking for the same thing with the 2D game:

* clarity of actions (can I tell what's going on based on sound?) 
* consistency (does the sound seem to match with the visuals and animations?)
and, most importantly, 
* a sense of style/aesthetics (are the sounds augmenting the game in a way that gives it life and character?).

But now, you have the added challenge of:
* making distinctive/believable spaces
* providing your player with spatial gameplay cues using sound

You will lose points for:
* Any Unmodified samples.  You need to modify and/or layer the sounds from freesound in some way (changing pitch, stretching, adding effects, etc).
* Repeating sounds for different actions  Again, treat your samples like ingredients.
* Sounds that start "late" - your sounds should have little to no silence (0.01 seconds max) at the beginning
* Sounds that end "early" - your sounds should always fade to silence.
* Loops with clearly audible seams (I can tell when the loop repeats)

WEEK 6 ASSIGNMENT- Recording Foley and Ambience
------
Foley: [Watch this video](https://www.youtube.com/watch?v=039xgixZPeg&feature=emb_title), and pick out 2 sound actions.  Try to recreate the sound using things that you record.  Do not use any effects, with the exception of noise removal, volume changes, and dynamic range compression.  

Ambience: pick 2 images [from this folder](https://drive.google.com/drive/folders/1crH3rB_iBnjYC5phnSvvsGE4U8avDhPO?usp=sharing).  Create a stereo ambience loop (10-30 seconds) for each of them, using sounds that you record (you can use some effects for this one).  this could be a bit abstract, or more realistic.

When you're finished, upload your sounds in a folder [HERE](https://drive.google.com/drive/folders/16z3TcV2Xj5oUtiaf0OzNpj5lUbr_mKG5?usp=sharing), with a document detailing the time stamps for your actions


WEEK 5 ASSIGNMENT- 2D reskin part 2
------
Your creative director applauds your efforts, but wants to go in a different direction for the audio design.  

You've been assigned one of the MYSTERY PACKS from [HERE](https://drive.google.com/drive/folders/1e5dkyT4-45uv0sO0fd0s2fYW0lsx-3yV?usp=sharing)

You can do whatever you want with these samples or recordings, but cannot use audio from anywhere else!

When you're done, please [UPLOAD YOUR BUILDS HERE](https://drive.google.com/drive/folders/1CRcqZYwboXL1LyDavhoafVpyCxHVNZhM?usp=sharing)


WEEK 4 ASSIGNMENT- 2D reskin part 1
------
Due Monday, September 28 at 4 pm Eastern

~~You can either make a web build on itch.io, or~~ upload a build [HERE](https://drive.google.com/drive/folders/1nW34lIzy_uobQxuW0uwQGyaZqYYVl5Io?usp=sharing) (make sure to upload a Windows build if you do)

~~Here's a [tutorial video](https://www.loom.com/share/2da0741391f243c5814be9a17b4a8f5e) on how to make a web build and upload it to itch.io~~ -- The Unity Audio Mixer doesn't work properly on web builds :( we'll stick to desktop builds for this assignment

Gabe Cuzzillo's game "Block Dog" is silent.  Clone this repo, open BlockDog in Unity Hub, and give it sound!

If you need a Unity refresher, are new to the program, or just need a written refence on what to do, you can find a write up [HERE](https://docs.google.com/document/d/1Iy4nT3MbeoLoDfEP5K5wEiEsUHY7wQRriO0M3FbfPro/edit?usp=sharing)

You should be working in the Scene called "Block Dog", on the Prefab called "AudioDirector."  Your work begins at the header **Start Editing Stuff Here**. The minimum is to create **12** assets for the game.  2 of these are loops - the Danger Loop and the Background Music (which could also be background ambience, if you prefer)

You can use:
* Whatever you find on the internet, or in the Audio for Digital Games Library.
* Anything using synthesis, if you wish.  [VCV rack](https://vcvrack.com/) can make some cool sounds (you need to download a recording module to write to files).
* Any effects, including vst plugins that you find on the internet.  For example, [this](https://glitchmachines.com/products/fracture/) is a free one that was used a lot on the game Prey, and can mangle sounds into something completely different!
* If you want to record sounds, you can do that too.

You are free to make any code modifications, as long as they only affect the audio

Things to avoid:
* Any Unmodified samples.  You need to modify the sounds from freesound or the library in some way (changing pitch, layering, stretching, adding effects, etc).
* Repeating sounds for different actions (for example, using the same sound for "jump" as for "throw").  Try to re-use *portions* of a sound in other sounds.  
* Sounds that start "late" - your sounds should have little to no silence (0.01 seconds max) at the beginning
* Sounds that end "early" - your sounds should always fade to silence.  
* Clicks/Pops in your loops

Aim for 
* clarity of actions (can I tell what's going on based on sound?) 
* consistency (does the sound seem to match with the visuals and animations?)
and, most importantly, 
* a sense of style/aesthetics (are the sounds augmenting the game in a way that gives it life and character?).

WEEK 3 ASSIGNMENT
-----
DUE Monday, September 21 at 4 pm.  
Note that the syllabus also has a listening assignment, but I'm going to incorporate a bit of that into the video that I'm making.

Choose 2 video clips from [THIS FOLDER](https://drive.google.com/drive/folders/1bGvPFMQD_xCOoOjnQaRnyDo0dFrCqcWE?usp=sharing).  If you want, you can find your own, provided that they are roughly 10 seconds long and contains a decent amount of gameplay footage (more than just footsteps).

Add sound effects to accompany the gifs.  The goal for the first pass is to have a distinct sound for every distinct motion - try to make it believable, as if the motions in the gif are producing the sound. 

Then, do a "second pass."  Choose different source material, and take a different artistic direction.  Try to still have sound for almost every motion, but go against convention! 

Render these (there should be 4 total) as WEBM videos and [upload them here when you're done](https://drive.google.com/drive/folders/1jvjoJ3HUWcMMyps0ms-OdQQZTIyXClmW?usp=sharing).  Make a sub-folder with your name.


WEEK 2 ASSIGNMENTS
------


DUE Monday, September 14 at 4 pm.  This assignment is also avalable [AT THIS LINK](https://docs.google.com/document/d/1-brqxZFMzU7TiCHPviXjwtxdSyuLEn5Pa6WXwRQ5lkc/edit?usp=sharing), where you can respond in writing if you wish.

**Creating:** Make a 1-3 minute "Sound Story" In Reaper, and upload it [HERE](https://drive.google.com/drive/folders/1LbdIesTbLyCatF_265w0hd8fuylM9vT4?usp=sharing).  

It might help to start with a setting that you want to convey, or some kind of scenario (like.. a LARP Battle in the Forest, or a High Speed Bicyle Chase), or you can just grab a bunch of different sounds and make an audio collage!  Try to Experiment with changes in Envelopes, Pitch, Panning, and Volume to tell your story.  

**Reading** [John Cage - Lecture on Nothing](https://seansturm.files.wordpress.com/2012/09/john-cage-lecture-on-nothing.pdf)

Read the first 3 pages

Consider or respond in writing:
 - Read a bit of the piece out loud, taking care to wait when there is space on the page
 - Py attention to the sounds that you hear in pauses between the words.  What do you hear?
 - Is this more a piece of music?  Of poetry?  Of just sounds?
 
**Listening:** [The Art Ensemble of Chicago - Illistrum](https://www.youtube.com/watch?v=xxjf54tsWEc)

Consider or respond in writing:
  - How many different instruments can you count in this piece?  Where do they use more tonal sounds?  More noisey ones?
  - How do you think the instruments and sound effects relate to the story?  Is it complementing the story?  Setting the scene?  Following the emotional arc?  
  - Are there moments where you think the instruments feel completely in sync with the storyteller?  or completely detached?



WEEK 1 ASSIGNMENTS
------

Reading - [Seeing Circles Signs & Signals: “Intro, Signals & Sound” & “Sines & Sampling”](https://jackschaedler.github.io/circles-sines-signals/)

Some questions to consider:
 - Where else have you heard the term "aliasing"?  Can you think of any time that you experienced "aliasing" and what it did?
 - What are some reasons we might "over-sample" audio?  Think about the ways we might be manipulating audio to create sound effects.
 - What are some reasons we might "under-sample" audio?  These might be practical decisions, or an aesthetic ones.
 - What is the lowest frequency range that we can record speech and still distinguish words?  Why do you think this is?

Listening - [Tristan Perich: 1-Bit Symphony](https://tristanperich.bandcamp.com/album/1-bit-symphony) - at least Movement 1.  TURN YOUR SOUND DOWN.

Things to consider when listening:
 - The reading had to do with frequencies, which affect sample _rate_ .  This music is constrained by bit depth, which restricts each sample's _amplitude_.
 - What does "1-bit" mean?  Why do you think the composer adopted this constraint?  What are some ways this piece generates variety using only 1 bit?  
 - Do you hear more pitches, or more noises in this piece?  Are there any places that seem more pitchy or more noisey?
 - How does this piece make you feel?  Do you associate it with any places, objects, or times? Or maybe other games, film, or music you've heard? 

If you wish, record some responses [On This Document](https://docs.google.com/document/d/1tRf_EwWJEI-p0qJuVaWIUiVvEZSH8LivPGvi1lVtUEQ/edit?usp=sharing), or be prepared to share yours in class on **Wednesday, September 9**



**Active Listening Presentation - Due in class at some point in the semester**
with a partner, play a game from the provided list, [available here](https://docs.google.com/spreadsheets/d/1hqdDCL9Sxn1z2aqPhcGguGxTOhXIV_HvDg4cryX9pDI/edit?usp=sharing), or make a case for a different game.  I ask that you don't watch a let's play, but I'll make exceptions if it's a specific kind of let's play relevant to audio or accessibility, or the game is not available anymore.  You might start by listing the sounds that you hear in the game, and rank them by importance.  How do you determing "important sounds" and how does the game distinguish these from the rest? How would you describe the overall audio aesthetic, mood, or feeling of the game?  How do sounds change in response to player action (some sounds may be randomized, or connected to in-game physics in interesting ways)?  Look up some facts about the creation of the game audio - what’s interesting about the techniques or technology used?

You will be presenting a brief (~7 minute) presentation during a lab time; please schedule your time in that sheet by **September 9**.  It's ok if you don't know which game you want to do quite yet.  If you have the means, please record this to a video.  Otherwise, make sure to make share your slides before class so we can view any video examples without Zoom compression.

You can share slides, resources, videos, or other interesting finds [HERE](https://drive.google.com/drive/folders/1I7tUAb3LxKi-FKV1gSQNQwZGOVw0iQFn?usp=sharing)
