ffmpeg -start_number 10 -framerate 2 -i dragon%%03d.png -c:v libx264 -r 25 -pix_fmt yuv420p out.mp4