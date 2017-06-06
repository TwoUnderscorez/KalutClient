import socket
import json
import time

mysoc = socket.socket()
HOST='kalut.ml'
PORT=50000
BUFSIZ=1024
ADDR=(HOST, PORT)
def setup():
    global mysoc
    mysoc = socket.socket()
    mysoc.connect(ADDR)

def connect(name, pin):
    data = {
        'name' : name,
        'pin' : pin
    }
    return send_and_ret_data(data)

def get_list_of_players():
    data = {
        'request' : 'get_players',
        'args' : []
    }
    return send_and_ret_data(data)

def wait_for_server():
    data = {
        'request' : 'register_event',
        'args' : []
    }
    return send_and_ret_data(data)

def answer(ans, t):
    data = {
        'request' : 'answer',
        'args' : [str(ans), t]
    }
    return send_and_ret_data(data)

def wallview_next_q():
    data = {
        'request' : 'wallview_next_q',
        'args' : []
    }
    return send_and_ret_data(data)
    
def send_and_ret_data(data):
    global mysoc
    recved_data = None
    try:
        mysoc.send(json.dumps(data))
        recved_data = mysoc.recv(1024)
    except:
        data = json.dumps({'status' : 'socket closed'})
        mysoc.close()
    if recved_data:
        return recved_data
    else:
        return json.dumps({'status' : 'socket closed'})

def close():
    global mysoc
    mysoc.close()

def get_time():
    return time.time()