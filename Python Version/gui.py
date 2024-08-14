import tkinter as tk
from tkinter import ttk
from tkinter import PhotoImage
from threading import Thread
from pathlib import Path
import tempfile
import requests
import os


start = tk.Tk()
start.geometry('1200x700')
start.title('')


script_path = os.path.abspath(__file__)
script_dir = os.path.dirname(script_path)
icon = PhotoImage(file=script_dir + "\drp.png")
start.iconphoto(False, icon) 

# Cloudflare 1.1.1.1
def cloud():
    url = 'https://1111-releases.cloudflareclient.com/win/latest'
    response = requests.get(url, stream=True)
    filename = 'Cloudflare.msi'
    file_path = Path(tempfile.gettempdir()) / filename
    
    d = Path(tempfile.gettempdir())
    print(f'Downloading {filename} to {d}')
    
    with open(file_path, 'wb') as f:
        for chunk in response.iter_content(chunk_size=8192):
         if chunk:
              f.write(chunk)
              
def start_cloudflare():
    thread = Thread(target=cloud)
    thread.start()






# Buttons
ttk.Button(
    start, 
    text="Cloudflare", 
    command=start_cloudflare,
    width=20,
    padding=(10, 20)
    
).pack()



    










start.mainloop()
