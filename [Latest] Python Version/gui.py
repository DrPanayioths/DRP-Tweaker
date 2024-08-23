import tkinter as tk
from tkinter import ttk
from tkinter import PhotoImage
from threading import Thread
from pathlib import Path
import tempfile
import requests
import os
import ctypes
import sys
import subprocess

# Admin Elevation
def run_as_admin():
    if not ctypes.windll.shell32.IsUserAnAdmin():
        ctypes.windll.shell32.ShellExecuteW(None, "runas", sys.executable, ' '.join([f'"{arg}"' for arg in sys.argv]), None, 1)
        sys.exit()
run_as_admin()
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
    
    process = subprocess.Popen([str(file_path)], shell=True)
    process.wait()
    print(f"Running Cloudflare Installer completed successfully!")

    if process.returncode != 0:
        os.remove(file_path)
def start_cloudflare():
    thread = Thread(target=cloud)
    thread.start()


# Malwarebytes
def malwarebytes():
    url = 'https://downloads.malwarebytes.com/file/mb-windows'
    response = requests.get(url, stream=True)
    filename = 'Malwarebytes.exe'
    file_path = Path(tempfile.gettempdir()) / filename
    
    temp = Path(tempfile.gettempdir())
    print(f'Downloading {filename} to {temp}')
    
    with open(file_path, 'wb') as f:
        for chunk in response.iter_content(chunk_size=8192):
         if chunk:
              f.write(chunk)

    process = subprocess.Popen([str(file_path)], shell=True)
    process.wait()
    print(f"Running MalwareBytes Installer completed successfully!")

    if process.returncode != 0:
        os.remove(file_path)
    
def start_malwarebytes():
    thread = Thread(target=malwarebytes)
    thread.start()




# Arc Browser
def arc():
    url = 'https://releases.arc.net/windows/ArcInstaller.exe'
    response = requests.get(url, stream=True)
    filename = 'Arc_Installer.exe'
    file_path = Path(tempfile.gettempdir()) / filename
    
    temp = Path(tempfile.gettempdir())
    print(f'Downloading {filename} to {temp}')
    
    with open(file_path, 'wb') as f:
        for chunk in response.iter_content(chunk_size=8192):
         if chunk:
              f.write(chunk)
    

    process = subprocess.Popen([str(file_path)], shell=True)
    process.wait()
    print(f"Running Arc Installer completed successfully!")
    
    if process.returncode != 0:
        os.remove(file_path)
def start_arc():
    thread = Thread(target=arc)
    thread.start()





# Labels

tk.Label(
    start, 
    text="Programs", 
    font=("Arial", 15),
    width=20,
    padx=10, 
    pady=20
).grid(row=0)



# Buttons
ttk.Button(
    start, 
    text="Cloudflare", 
    command=start_cloudflare,
    width=20,
    padding=(10, 20)
).grid(row=1)

ttk.Button(
    start,
    text="Malwarebytes", 
    command=start_malwarebytes,
    width=20,
    padding=(10, 20)
).grid(row=2)

ttk.Button(
    start,
    text="Arc Browser", 
    command=start_arc,
    width=20,
    padding=(10, 20)
).grid(row=3)
    










start.mainloop()
