from flask import Flask
from flask import request, jsonify
from flask_cors import CORS, cross_origin\

# Khai bao cong cua server
my_port = '8000'

# Doan ma khoi tao server
app = Flask(__name__)
CORS(app)

# Khai bao ham xu ly request index
@app.route('/')
@cross_origin()
def index():
    return "Welcome to flask API!"

# Khai bao ham xu ly request hello_word
@app.route('/hello_world', methods=['GET'])
@cross_origin()
def hello_world():
    # Lay staff id cua client gui len
    staff_id = request.args.get('staff_id')
    # Tra ve cau chao Hello
    return "Hello "  + str(staff_id)


# Thuc thi server
if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0',port=my_port)