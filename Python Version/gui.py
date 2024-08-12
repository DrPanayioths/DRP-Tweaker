import tkinter as tk
from tkinter import ttk
from threading import Thread
import requests

start = tk.Tk()
start.geometry('1200x700')
start.title('')


# Cloudflare 1.1.1.1
def cloud():
    url = 'https://1111-releases.cloudflareclient.com/win/latest'
    response = requests.get(url)
    filename = 'Cloudflare.msi'
    with open(filename, 'wb') as f:
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
    command=start_cloudflare
).pack()



    










start.mainloop()
